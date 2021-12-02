SELECT
  [Date]
  ,[Temperature]
  ,AVG([Temperature]) OVER (
    ORDER BY [Date]
    ROWS BETWEEN 2 PRECEDING AND 2 FOLLOWING
  ) MovingAverageFiveDayTemp
FROM [SensorData]