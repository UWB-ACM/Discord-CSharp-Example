﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CSSBot.Reminders
{
    [XmlRoot("ReminderList")]
    public class ReminderList
    {
        [XmlElement("ReminderCounter")]
        public int ReminderCounter { get; set; }

        [XmlElement("Reminders")]
        public List<Reminder> Reminders { get; set; }

        public ReminderList()
        {
            Reminders = new List<Reminder>();
        }
    }
}