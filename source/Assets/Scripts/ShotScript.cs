﻿using UnityEngine;

/// <summary>
/// Projectile behavior
/// </summary>
public class ShotScript : MonoBehaviour
{
  // 0 - Designer variables

  /// <summary>
  /// Damage inflicted
  /// </summary>
  public int Damage = 1;

  /// <summary>
  /// Projectile damage player or enemies?
  /// </summary>
  public bool IsEnemyShot = false;

  void Start()
  {
    // 1 - Limited time to live to avoid any leak
    Destroy(gameObject, 20); // 20sec
  }
}