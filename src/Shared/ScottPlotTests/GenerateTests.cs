﻿using ScottPlot;
using System;

namespace SharedTests;

internal class GenerateTests
{
    [Test]
    public void Test_RandomNormal()
    {
        double[] values = Generate.RandomNormal(10);
        Console.WriteLine(string.Join(Environment.NewLine, values.Select(x => x.ToString())));
    }
}
