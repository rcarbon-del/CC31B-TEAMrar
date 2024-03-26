using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 26 March 2024 Added the QuestStatus class to the Engine.Models namespace
namespace Engine.Models
{
    public class QuestStatus : BaseNotificationClass
    {
        public Quest PlayerQuest { get; set; }
        public bool IsCompleted { get; set; }
        public QuestStatus(Quest quest)
        {
            PlayerQuest = quest;
            IsCompleted = false;
        }
    }
}
