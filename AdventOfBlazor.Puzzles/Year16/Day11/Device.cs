﻿using System.Diagnostics;

namespace AdventOfBlazor.Puzzles.Year16.Day11;

[DebuggerDisplay("{Element, nq}, {DeviceType}")]
public record Device(string Element, DeviceType DeviceType)
{
    public bool IsMicrochip => DeviceType == DeviceType.Microchip;
}
