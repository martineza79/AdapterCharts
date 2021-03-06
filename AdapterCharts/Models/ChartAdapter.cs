﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace AdapterCharts.Models
{
    public class ChartAdapter : IChart
    {
        public string Title { get; set; }
        public List<string> XData { get; set; }
        public List<int> YData { get; set; }

        public Bitmap GenerateChart()
        {
            ThirdPartyChartGenerator chart = new ThirdPartyChartGenerator();
            return chart.DrawChart(Title, XData, YData);
        }
    }
}