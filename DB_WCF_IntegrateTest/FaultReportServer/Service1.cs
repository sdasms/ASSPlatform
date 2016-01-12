using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.IdentityModel.Tokens;
using System.IdentityModel.Selectors;
using System.Text;

namespace FaultReportServer
{
    public class FaultReportService : IFaultReportContract
    {
        public int AutoFaultReport(string InstrumentUID, string FaultCode, string FaultDetail, DateTime FaultTime)
        {
            using (FaultDataContext fdc = new FaultDataContext())
            {
                try
                {
                    var jointQuery = (from e in fdc.Instrument
                                      join c in fdc.FaultType on
                                      e.Type equals c.InstrumentTypeID
                                      where e.GUID == InstrumentUID && c.FaultCode == FaultCode
                                      select
                                      new
                                      {
                                          FaultType = c,
                                          InstrumentType = e.Type,
                                      });
                    if (jointQuery.Count() > 0)
                    {
                        UpdateIntrumentOnlineStatus(InstrumentUID, true);
                        var eventCount = (from e in fdc.FixEvent
                                          where e.FaultTime == FaultTime && e.FaultType == FaultCode && e.InstrumentID == InstrumentUID
                                          select e).Count();
                        if (eventCount > 0)
                            return -1;
                        else
                        {
                            var result = jointQuery.First();
                            FixEvent NewFix = new FixEvent
                            {
                                Auditted = false,
                                FaultTime = FaultTime,
                                FaultType = result.FaultType.FaultCode,
                                FinishDeadline = FaultTime.AddDays(30),
                                DispatchDeadline = FaultTime.AddDays(7),
                                InstrumentID = InstrumentUID,
                                InstrumentType = result.InstrumentType,
                                RecentStatusTime = FaultTime,
                                CurrentStatusID = 1,
                                FaultDetail = FaultDetail,
                            };
                            fdc.FixEvent.InsertOnSubmit(NewFix);
                            fdc.SubmitChanges();
                            var eventId = (from e in fdc.FixEvent
                                           where e.InstrumentID == InstrumentUID && e.RecentStatusTime == FaultTime && e.FaultType == result.FaultType.FaultCode
                                           select e.ID).First();
                            var history = new InstrumentStatusHistory { FixEventID = eventId, StatusChangeTime = FaultTime, StatusID = 1 };
                            fdc.InstrumentStatusHistory.InsertOnSubmit(history);
                            fdc.SubmitChanges();
                            return eventId;
                        }
                    }
                    else
                        return -1;
                }
                catch (ArgumentNullException ex)
                {
                    throw new FaultException<ArgumentNullException>(new ArgumentNullException(ex.ParamName, "维修提交失败"));
                }
                
            }
        }

        public void SendAttachedFile(string InstrumentID, int FixEventID, byte[] AttachedFile)
        {
            var length = AttachedFile.Length;
            var content = AttachedFile[10000];
            using (FaultDataContext fdc = new FaultDataContext())
            {
                try
                {
                    var instruemntID = (from e in fdc.FixEvent
                                 where e.ID == FixEventID
                                 select e).First().InstrumentID;
                    if (instruemntID == InstrumentID)
                    {
                        EventAttachedFile fileInfo = new EventAttachedFile { FixEventID = FixEventID, FileName = @"c:\123.bin" + length + content + DateTime.Now.Ticks, UploadTime = DateTime.Now };
                        fdc.EventAttachedFile.InsertOnSubmit(fileInfo);
                        fdc.SubmitChanges();
                    }
                }
                catch(ArgumentNullException)
                {
                    throw new FaultException("event not exist");
                }

            }
        }

        public bool ManualFaultReport(CustomerReport Report)
        {
            using (FaultDataContext fdc = new FaultDataContext())
            {
                try
                {
                    var CustomerReport = new CustomerReportFault
                    {
                        Description = Report.Descripton,
                        ProjectID = Report.ProjectID,
                        ProjectName = Report.ProjectName
                    };
                    fdc.CustomerReportFault.InsertOnSubmit(CustomerReport);
                    fdc.SubmitChanges();
                    return true;
                }
                catch
                {
                    throw;
                }
            }
        }

        public void TellNetStatus(string InstrumentUID, bool IsOnline)
        {
            UpdateIntrumentOnlineStatus(InstrumentUID, IsOnline);
        }

        private static void UpdateIntrumentOnlineStatus(string InstrumentUID, bool IsOnline)
        {
            using (FaultDataContext fdc = new FaultDataContext())
            {
                try
                {
                    var query = from e in fdc.Instrument
                                where e.GUID == InstrumentUID
                                select e;
                    if (query.Count() == 0)
                        return;
                    else
                    {
                        var instrument = query.First();
                        instrument.IsOnline = IsOnline;
                        instrument.LastUpdateTime = DateTime.Now;
                        fdc.SubmitChanges();
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
    }

    public class MyUsernamePasswordValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            using (FaultDataContext fdc = new FaultDataContext())
            {
                var result = from e in fdc.TransitServer
                             where e.Username == userName
                             select e;
                if (result.Count() > 0)
                    if (result.First().Password != password)
                        throw new FaultException("wrong password");
                    else 
                    { }
                else
                {
                    throw new FaultException("username not exist");
                }
            }
        }
    }
}
