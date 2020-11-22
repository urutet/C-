﻿using System;
using System.Collections.Generic;
namespace lab9
{
    public class PLanguagesClass
    {
        string Name { get; set; }
        string Version { get; set; }
        List<string> Features { get; set; }

        public event EventHandler Rename;
        public event EventHandler NewVersion;
        public event EventHandler NewFeature;

        public PLanguagesClass()
        {

        }

        public PLanguagesClass(string name, string version, List<string> features)
        {
            Name = name;
            Version = version;
            Features = new List<string>();
            foreach (string feature in features)
            {
                Features.Add(feature);
            }
        }

        public void CommandRename(string name)
        {
            //Console.WriteLine($"Language {Name} has been renamed to {name}!");
            Name = name;
            Rename?.Invoke(this, null);
        }

        public void CommandNewVersion(string version)
        {
            //Console.WriteLine($"Version {Version} has been updated to {version}!");
            Version = version;
            NewVersion?.Invoke(this, null);
        }

        public void CommandNewFeature(string feature)
        {
            if (Features == null)
            {
                Features = new List<string>();
                Features.Add(feature);
                NewFeature?.Invoke(this, null);
            }
            else
            {
                Features.Add(feature);
                //Console.WriteLine($"New feature {feature} has been added to {Name}!");
                NewFeature?.Invoke(this, null);
            }
        }
    }
}