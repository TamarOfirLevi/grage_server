using GarageDAL;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using GarageModels;

namespace GarageBL
{
    public static class MishapQueue
    {

        private static Timer aTimer;
        //private static ConcurrentQueue<Mishaps> _queue;
        private static List<QueueItem> _queueUrgency;
        private static List<QueueItem> _queuePrice;

        static MishapQueue()
        {
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 2000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Start();
        }

        public static List<QueueItem> QueueUrgency
        {
            get
            {
                if (_queueUrgency == null)
                {
                    _queueUrgency = new List<QueueItem>();
                }

                return _queueUrgency;
            }

            set
            {
                _queueUrgency = value;
            }
        }

        public static List<QueueItem> QueuePrice
        {
            get
            {
                if (_queuePrice == null)
                {
                    _queuePrice = new List<QueueItem>();
                }

                return _queuePrice;
            }

            set
            {
                _queuePrice = value;
            }
        }


        //public static ConcurrentQueue<Mishaps> Queue
        //{
        //    get
        //    {
        //        if (_queue == null)
        //        {
        //            _queue = new ConcurrentQueue<Mishaps>();
        //        }

        //        return _queue;
        //    }
        //}

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            updateLists();
        }

        private static void updateLists() {
            QueueUrgency.RemoveRange(0, QueueUrgency.Count);
            QueuePrice.RemoveRange(0, QueuePrice.Count);
            //_queueUrgency.AddRange(MishapDataBase.MishapDal.GetAllMishaps("Mishap_Status", c => c.mishap_urgency));
            //_queuePrice.AddRange(MishapDataBase.MishapDal.GetAllMishaps("Mishap_Status", c => c.mishap_price));

            var mishaps = MishapDataBase.MishapDal.GetAllMishap("Mishap_Status", c => c.mishap_urgency).ToList();
            for (int i = 0; i < mishaps.Count; i++)
            {
                QueueUrgency.Add(new QueueItem() {
                    mishap = mishaps[i],
                    priority = i
                });
            }

            mishaps = MishapDataBase.MishapDal.GetAllMishap("Mishap_Status", c => c.mishap_price).ToList();
            for (int i = 0; i < mishaps.Count; i++)
            {
                QueuePrice.Add(new QueueItem()
                {
                    mishap = mishaps[i],
                    priority = i
                });
            }
        }
    }

    public class QueueItem
    {
        public Mishap mishap;
        public int priority;
    }
}
