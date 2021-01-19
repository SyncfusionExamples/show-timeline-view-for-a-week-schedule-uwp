using Microsoft.Xaml.Interactivity;
using Syncfusion.UI.Xaml.Schedule;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace ScheduleUWP
{
    public class SchedulerBehavior : Behavior<SfSchedule>
    {
        SfSchedule schedule;
        protected override void OnAttached()
        {
            base.OnAttached();
            schedule = this.AssociatedObject;
            ObservableCollection<DateTime> dateTimes = new ObservableCollection<DateTime>();
            dateTimes.Add(new DateTime(2021, 01, 4));
            dateTimes.Add(new DateTime(2021, 01, 5));
            dateTimes.Add(new DateTime(2021, 01, 6));
            dateTimes.Add(new DateTime(2021, 01, 7));
            dateTimes.Add(new DateTime(2021, 01, 8));
            dateTimes.Add(new DateTime(2021, 01, 9));
            dateTimes.Add(new DateTime(2021, 01, 10));
            schedule.ScheduleDateRange = dateTimes;
            this.AssociatedObject.SizeChanged += Schedule_SizeChanged;
        }
        private void Schedule_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.AssociatedObject.IntervalHeight = e.NewSize.Width / 14;
        }
        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.SizeChanged -= Schedule_SizeChanged;
            this.schedule = null;
        }
    }
}

        
    
  