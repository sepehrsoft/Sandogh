﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Sandogh.App.Convertor
{
    class ActivityConvertor : IValueConverter
    {
        enum Activity
        {
            غیرفعال , فعال
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case false:
                    return Activity.غیرفعال;
                case true:
                    return Activity.فعال;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case Activity.غیرفعال:
                    return 0;
                case Activity.فعال:
                    return 1;
            }
            return null;
        }
    }
}
