﻿using UnityEngine;
using System.Collections.Generic;

public interface IMoveStrategy
{
    List<Vector2> GetAvailableTiles(Vector2 Origin, PieceColor MovingColor);
    List<Vector2> UnsafeGetAvailableTiles(Vector2 Origin, PieceColor MovingColor);
    void Move(Tile Destination);
}