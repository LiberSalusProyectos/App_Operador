using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion.SfCalendar.XForms;


namespace App_Op
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pag_Calendario : ContentPage
	{
        
        public Pag_Calendario ()
		{
			InitializeComponent ();
            SfCalendar calendar = new SfCalendar();
            calendar.ShowInlineEvents = true;

            CalendarInlineEvent events = new CalendarInlineEvent();
            CalendarInlineEvent reunion = new CalendarInlineEvent();
            reunion.StartTime = new DateTime(2018, 10, 1, 17,30,00);
            reunion.EndTime = new DateTime(2018, 10, 1, 19, 0, 0);            
            reunion.Subject = "Junta Liber Salus";            
            reunion.Color = Color.Aqua;           

            events.StartTime = new DateTime(2018, 10, 11, 12, 0, 0);
            events.EndTime = new DateTime(2018, 10, 11, 14, 0, 0);
            events.Subject = "Junta Diana";
            events.Color = Color.Magenta;

            CalendarEventCollection collection = new CalendarEventCollection();
            

            collection.Add(events);
            collection.Add(reunion);

            calendar.DataSource = collection;
            //calendar.DataSource = collection;

            this.Content = calendar;

        }
        
    }
}