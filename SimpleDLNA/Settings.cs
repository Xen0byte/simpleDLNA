﻿using System;
using System.Collections.Generic;

namespace NMaier.SimpleDlna.GUI.Properties
{
  internal sealed partial class Settings
  {
    public Settings()
    {
      try
      {
        if (MustUpgrade)
        {
          Upgrade();
          MustUpgrade = false;
          Save();
        }
      }
      catch (Exception)
      {
      }
    }

    [UserScopedSetting]
    [DefaultSettingValue("")]
    public List<ServerDescription> Descriptors
    {
      get => this["Descriptors"] as List<ServerDescription>;
      set => this["Descriptors"] = value;
    }
  }
}
