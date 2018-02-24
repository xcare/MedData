using Dapper;
using XCare.DMS.Message.Ypzd;

namespace XCare.DMS.DataProc.MessageHandler.Ypzd
{
    public class YpzdCreatedMessageHandler : IMessageHandler<YpzdCreatedMessage>
    {
        public bool Handle(YpzdCreatedMessage message)
        {
            using (var conn = DbUtil.GetDbConnection())
            {
                conn.Execute(@"
IF NOT EXISTS ( SELECT  0
                FROM    dbo.YDHL_YPZD
                WHERE   YPMC = @YPMC ) 
   BEGIN
         INSERT INTO dbo.YDHL_YPZD ( ID, XH, YPMC, YPJC )
         VALUES ( @ID, -- ID - uniqueidentifier
                  @XH, -- XH - int
                  @YPMC, -- YPMC - nvarchar(50)
                  @YPJC  -- YPJC - nvarchar(8)
                  )
   END", new
                {
                    ID = message.Yp.Id,
                    XH = message.Yp.Xh,
                    YPMC = message.Yp.Ypmc,
                    YPJC = message.Yp.Ypjc
                });
            }
            return true;
        }
    }
}