﻿using Dapper.FluentMap.Mapping;

namespace ShippingPlatform.DataBase.Mappers
{
    class NotificationMapper : EntityMap<Notification>
    {
        public NotificationMapper()
        {
            Map(x => x.id).ToColumn("id_notifications");
            Map(x => x.clientEmail).ToColumn("client_mail");
            Map(x => x.recipientEmail).ToColumn("recipient_mail");
            Map(x => x.message).ToColumn("message");
            Map(x => x.subject).ToColumn("subject");
            Map(x => x.timeStamp).ToColumn("time_stamp");
            Map(x => x.orderId).ToColumn("id_order");
            Map(x => x.attachmentId).ToColumn("attachment");
        }
    }
}
