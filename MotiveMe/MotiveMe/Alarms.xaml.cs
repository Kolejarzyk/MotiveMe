int nap;
string audioSrc;
int year = datepicker.Date.Year;
int month = datepicker.Date.Month;
int day = datepicker.Date.Day;
int hour = timepicker.Time.Hours;
int min = timepicker.Time.Minutes;
int sec = timepicker.Time.Seconds;
//   string audioSrc = alrm_sound.SelectionBoxItem.ToString();
    DateTime myDate1 = new DateTime(year, month, day, hour, min, sec);
    
    DateTime myDate2 = DateTime.Now;
    TimeSpan myDateResult = new TimeSpan();
    myDateResult = myDate1 - myDate2;
    if (myDate2 > myDate1)
    {
        var x = new MessageDialog("Invalid date or time");
        await x.ShowAsync();
    }
    else
    {
        string title = "Alarm!";
        string message = alm_msg.Text;
        string imgURL = "ms-appx:///Assets/Capture.PNG";
        
        string toastXmlString =
         "<toast><visual version='1'>
         <binding template='toastImageAndText02'><text id='1'> + title + "</text><text id='2'>" + message + "</text><image id='1' src='" +
         imgURL + "'/></binding></visual>\n" +
          "<commands scenario=\"alarm\">\n" +
                "<command id=\"nap\"/>\n" +
                "<command id=\"dismiss\"/>\n" +
            "</commands>\n" +
            
                  "<audio src='ms-winsoundevent:Notification." + audioSrc + "'/>" +
            "</toast>";
            
        Windows.Data.Xml.Dom.XmlDocument toastDOM = new Windows.Data.Xml.Dom.XmlDocument();
        toastDOM.LoadXml(toastXmlString);
        var toastNotifier1 = Windows.UI.Notifications.ToastNotificationManager.CreateToastNotifier();
        
        double x1 = myDateResult.TotalSeconds;
        int customSnoozeSeconds = snooze * 60;
        
        TimeSpan snoozeInterval = TimeSpan.FromSeconds(customSnoozeSeconds);
        
        var customAlarmScheduledToast = new Windows.UI.Notifications.ScheduledToastNotification
        (toastDOM, DateTime.Now.AddSeconds(x1), snoozeInterval, 0);
        
        toastNotifier1.AddToSchedule(customAlarmScheduledToast);
        var x = new MessageDialog("Alarm Set!");
        await x.ShowAsync();
    }