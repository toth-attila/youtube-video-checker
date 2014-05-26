using NLog;
using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace YoutubeVideoChecker.Helper
{
    public class ObservableObject : INotifyPropertyChanged
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
                if (logger.IsTraceEnabled)
                {
                    logger.Trace("'{0}' property changed", propertyName);
                }
            }
        }
    }

}
