﻿using Unity.Entities;

public struct Tilled : IComponentData
{
    public int FertilityLeft;
    public Entity TilledDisplayPrefab;
}
