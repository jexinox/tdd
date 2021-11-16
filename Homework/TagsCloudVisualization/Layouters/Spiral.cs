﻿using System;
using System.Drawing;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TagsCloudVisualizationTests")]

namespace TagsCloudVisualization.Layouters
{
    internal class Spiral : IPointLayouter
    {
        // ReSharper disable RedundantDefaultMemberInitializer
        private float radius = 0;
        private float angle = 0;

        private readonly Point center;

        public PointF CurrentPoint =>
            new((float) Math.Cos(angle) * radius + center.X,
                (float) Math.Sin(angle) * radius + center.Y);


        public Spiral(Point center)
        {
            this.center = center;
        }

        public void GetNextPoint()
        {
            // ReSharper disable once IntroduceOptionalParameters.Global
            IncreaseSize(0.01f, 0.01f);
        }

        public void IncreaseSize(float radiusIncreaseValue, float angleIncreaseValue)
        {
            radius += radiusIncreaseValue;
            angle += angleIncreaseValue;
        }
    }
}