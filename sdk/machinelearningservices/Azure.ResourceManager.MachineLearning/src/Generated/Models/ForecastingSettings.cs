// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Forecasting specific parameters. </summary>
    public partial class ForecastingSettings
    {
        /// <summary> Initializes a new instance of ForecastingSettings. </summary>
        public ForecastingSettings()
        {
            FeaturesUnknownAtForecastTime = new ChangeTrackingList<string>();
            TimeSeriesIdColumnNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ForecastingSettings. </summary>
        /// <param name="countryOrRegionForHolidays">
        /// Country or region for holidays for forecasting tasks.
        /// These should be ISO 3166 two-letter country/region codes, for example 'US' or 'GB'.
        /// </param>
        /// <param name="cvStepSize">
        /// Number of periods between the origin time of one CV fold and the next fold. For
        /// example, if `CVStepSize` = 3 for daily data, the origin time for each fold will be
        /// three days apart.
        /// </param>
        /// <param name="featureLags"> Flag for generating lags for the numeric features with 'auto' or null. </param>
        /// <param name="featuresUnknownAtForecastTime">
        /// The feature columns that are available for training but unknown at the time of forecast/inference.
        /// If features_unknown_at_forecast_time is not set, it is assumed that all the feature columns in the dataset are known at inference time.
        /// </param>
        /// <param name="forecastHorizon">
        /// The desired maximum forecast horizon in units of time-series frequency.
        /// Please note <see cref="Models.ForecastHorizon"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoForecastHorizon"/> and <see cref="CustomForecastHorizon"/>.
        /// </param>
        /// <param name="frequency"> When forecasting, this parameter represents the period with which the forecast is desired, for example daily, weekly, yearly, etc. The forecast frequency is dataset frequency by default. </param>
        /// <param name="seasonality">
        /// Set time series seasonality as an integer multiple of the series frequency.
        /// If seasonality is set to 'auto', it will be inferred.
        /// Please note <see cref="ForecastingSeasonality"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoSeasonality"/> and <see cref="CustomSeasonality"/>.
        /// </param>
        /// <param name="shortSeriesHandlingConfig"> The parameter defining how if AutoML should handle short time series. </param>
        /// <param name="targetAggregateFunction">
        /// The function to be used to aggregate the time series target column to conform to a user specified frequency.
        /// If the TargetAggregateFunction is set i.e. not 'None', but the freq parameter is not set, the error is raised. The possible target aggregation functions are: "sum", "max", "min" and "mean".
        /// </param>
        /// <param name="targetLags">
        /// The number of past periods to lag from the target column.
        /// Please note <see cref="Models.TargetLags"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoTargetLags"/> and <see cref="CustomTargetLags"/>.
        /// </param>
        /// <param name="targetRollingWindowSize">
        /// The number of past periods used to create a rolling window average of the target column.
        /// Please note <see cref="Models.TargetRollingWindowSize"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoTargetRollingWindowSize"/> and <see cref="CustomTargetRollingWindowSize"/>.
        /// </param>
        /// <param name="timeColumnName"> The name of the time column. This parameter is required when forecasting to specify the datetime column in the input data used for building the time series and inferring its frequency. </param>
        /// <param name="timeSeriesIdColumnNames">
        /// The names of columns used to group a timeseries. It can be used to create multiple series.
        /// If grain is not defined, the data set is assumed to be one time-series. This parameter is used with task type forecasting.
        /// </param>
        /// <param name="useStl"> Configure STL Decomposition of the time-series target column. </param>
        internal ForecastingSettings(string countryOrRegionForHolidays, int? cvStepSize, MachineLearningFeatureLag? featureLags, IList<string> featuresUnknownAtForecastTime, ForecastHorizon forecastHorizon, string frequency, ForecastingSeasonality seasonality, MachineLearningShortSeriesHandlingConfiguration? shortSeriesHandlingConfig, TargetAggregationFunction? targetAggregateFunction, TargetLags targetLags, TargetRollingWindowSize targetRollingWindowSize, string timeColumnName, IList<string> timeSeriesIdColumnNames, MachineLearningUseStl? useStl)
        {
            CountryOrRegionForHolidays = countryOrRegionForHolidays;
            CvStepSize = cvStepSize;
            FeatureLags = featureLags;
            FeaturesUnknownAtForecastTime = featuresUnknownAtForecastTime;
            ForecastHorizon = forecastHorizon;
            Frequency = frequency;
            Seasonality = seasonality;
            ShortSeriesHandlingConfig = shortSeriesHandlingConfig;
            TargetAggregateFunction = targetAggregateFunction;
            TargetLags = targetLags;
            TargetRollingWindowSize = targetRollingWindowSize;
            TimeColumnName = timeColumnName;
            TimeSeriesIdColumnNames = timeSeriesIdColumnNames;
            UseStl = useStl;
        }

        /// <summary>
        /// Country or region for holidays for forecasting tasks.
        /// These should be ISO 3166 two-letter country/region codes, for example 'US' or 'GB'.
        /// </summary>
        public string CountryOrRegionForHolidays { get; set; }
        /// <summary>
        /// Number of periods between the origin time of one CV fold and the next fold. For
        /// example, if `CVStepSize` = 3 for daily data, the origin time for each fold will be
        /// three days apart.
        /// </summary>
        public int? CvStepSize { get; set; }
        /// <summary> Flag for generating lags for the numeric features with 'auto' or null. </summary>
        public MachineLearningFeatureLag? FeatureLags { get; set; }
        /// <summary>
        /// The feature columns that are available for training but unknown at the time of forecast/inference.
        /// If features_unknown_at_forecast_time is not set, it is assumed that all the feature columns in the dataset are known at inference time.
        /// </summary>
        public IList<string> FeaturesUnknownAtForecastTime { get; set; }
        /// <summary>
        /// The desired maximum forecast horizon in units of time-series frequency.
        /// Please note <see cref="Models.ForecastHorizon"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoForecastHorizon"/> and <see cref="CustomForecastHorizon"/>.
        /// </summary>
        public ForecastHorizon ForecastHorizon { get; set; }
        /// <summary> When forecasting, this parameter represents the period with which the forecast is desired, for example daily, weekly, yearly, etc. The forecast frequency is dataset frequency by default. </summary>
        public string Frequency { get; set; }
        /// <summary>
        /// Set time series seasonality as an integer multiple of the series frequency.
        /// If seasonality is set to 'auto', it will be inferred.
        /// Please note <see cref="ForecastingSeasonality"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoSeasonality"/> and <see cref="CustomSeasonality"/>.
        /// </summary>
        public ForecastingSeasonality Seasonality { get; set; }
        /// <summary> The parameter defining how if AutoML should handle short time series. </summary>
        public MachineLearningShortSeriesHandlingConfiguration? ShortSeriesHandlingConfig { get; set; }
        /// <summary>
        /// The function to be used to aggregate the time series target column to conform to a user specified frequency.
        /// If the TargetAggregateFunction is set i.e. not 'None', but the freq parameter is not set, the error is raised. The possible target aggregation functions are: "sum", "max", "min" and "mean".
        /// </summary>
        public TargetAggregationFunction? TargetAggregateFunction { get; set; }
        /// <summary>
        /// The number of past periods to lag from the target column.
        /// Please note <see cref="Models.TargetLags"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoTargetLags"/> and <see cref="CustomTargetLags"/>.
        /// </summary>
        public TargetLags TargetLags { get; set; }
        /// <summary>
        /// The number of past periods used to create a rolling window average of the target column.
        /// Please note <see cref="Models.TargetRollingWindowSize"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AutoTargetRollingWindowSize"/> and <see cref="CustomTargetRollingWindowSize"/>.
        /// </summary>
        public TargetRollingWindowSize TargetRollingWindowSize { get; set; }
        /// <summary> The name of the time column. This parameter is required when forecasting to specify the datetime column in the input data used for building the time series and inferring its frequency. </summary>
        public string TimeColumnName { get; set; }
        /// <summary>
        /// The names of columns used to group a timeseries. It can be used to create multiple series.
        /// If grain is not defined, the data set is assumed to be one time-series. This parameter is used with task type forecasting.
        /// </summary>
        public IList<string> TimeSeriesIdColumnNames { get; set; }
        /// <summary> Configure STL Decomposition of the time-series target column. </summary>
        public MachineLearningUseStl? UseStl { get; set; }
    }
}
