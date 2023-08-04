namespace AgileCoding.Extentions.TimeSpans
{
    using System;
    using AgileCoding.Extentions.Activators;

    public static class TimeSpanExtentions
    {
        public static TimeSpan ToTimeSpan(this string stringValue)
        {
            TimeSpan parseResult;
            TimeSpan.TryParse(stringValue, out parseResult);
            return parseResult;
        }

        public static TimeSpan ToTimeSpan<IExceptionType>(this string stringValue, string? errorMessage = null)
             where IExceptionType : Exception, new()
        {
            string tempErrorMessage = errorMessage == null
                ? $"Value provided '{stringValue}' is not a valid TimeSpan"
                : errorMessage;

            TimeSpan parseResult;
            if (!TimeSpan.TryParse(stringValue, out parseResult))
            {
                var exception =  typeof(IExceptionType).CreateInstanceWithoutLogging<IExceptionType>(tempErrorMessage);
                if (exception != null)
                {
                    throw exception;
                }
                else
                {
                    throw new Exception(tempErrorMessage);
                }
            }

            return parseResult;
        }
    }
}
