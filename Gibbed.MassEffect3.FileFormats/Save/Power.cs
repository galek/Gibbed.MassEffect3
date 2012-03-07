﻿/* Copyright (c) 2012 Rick (rick 'at' gibbed 'dot' us)
 * 
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 * 
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 * 
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 * 
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

using System.ComponentModel;

namespace Gibbed.MassEffect3.FileFormats.Save
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Power : Unreal.ISerializable, INotifyPropertyChanged
    {
        private string _PowerName;
        private float _CurrentRank;
        private int _EvolvedChoice0;
        private int _EvolvedChoice1;
        private int _EvolvedChoice2;
        private int _EvolvedChoice3;
        private int _EvolvedChoice4;
        private int _EvolvedChoice5;
        private string _PowerClassName;
        private int _WheelDisplayIndex;

        public void Serialize(Unreal.ISerializer stream)
        {
            stream.Serialize(ref this._PowerName);
            stream.Serialize(ref this._CurrentRank);
            stream.Serialize(ref this._EvolvedChoice0, (s) => s.Version < 30, () => 0);
            stream.Serialize(ref this._EvolvedChoice1, (s) => s.Version < 30, () => 0);
            stream.Serialize(ref this._EvolvedChoice2, (s) => s.Version < 31, () => 0);
            stream.Serialize(ref this._EvolvedChoice3, (s) => s.Version < 31, () => 0);
            stream.Serialize(ref this._EvolvedChoice4, (s) => s.Version < 31, () => 0);
            stream.Serialize(ref this._EvolvedChoice5, (s) => s.Version < 31, () => 0);
            stream.Serialize(ref this._PowerClassName);
            stream.Serialize(ref this._WheelDisplayIndex);
        }

        public override string ToString()
        {
            return this.PowerName;
        }

        #region Properties
        [DisplayName("Name")]
        public string PowerName
        {
            get { return this._PowerName; }
            set
            {
                if (value != this._PowerName)
                {
                    this._PowerName = value;
                    this.NotifyPropertyChanged("PowerName");
                }
            }
        }

        [DisplayName("Current Rank")]
        public float CurrentRank
        {
            get { return this._CurrentRank; }
            set
            {
                if (value != this._CurrentRank)
                {
                    this._CurrentRank = value;
                    this.NotifyPropertyChanged("CurrentRank");
                }
            }
        }

        [DisplayName("Evolved Choice #1")]
        public int EvolvedChoice0
        {
            get { return this._EvolvedChoice0; }
            set
            {
                if (value != this._EvolvedChoice0)
                {
                    this._EvolvedChoice0 = value;
                    this.NotifyPropertyChanged("EvolvedChoice0");
                }
            }
        }

        [DisplayName("Evolved Choice #2")]
        public int EvolvedChoice1
        {
            get { return this._EvolvedChoice1; }
            set
            {
                if (value != this._EvolvedChoice1)
                {
                    this._EvolvedChoice1 = value;
                    this.NotifyPropertyChanged("EvolvedChoice1");
                }
            }
        }

        [DisplayName("Evolved Choice #3")]
        public int EvolvedChoice2
        {
            get { return this._EvolvedChoice2; }
            set
            {
                if (value != this._EvolvedChoice2)
                {
                    this._EvolvedChoice2 = value;
                    this.NotifyPropertyChanged("EvolvedChoice2");
                }
            }
        }

        [DisplayName("Evolved Choice #4")]
        public int EvolvedChoice3
        {
            get { return this._EvolvedChoice3; }
            set
            {
                if (value != this._EvolvedChoice3)
                {
                    this._EvolvedChoice3 = value;
                    this.NotifyPropertyChanged("EvolvedChoice3");
                }
            }
        }

        [DisplayName("Evolved Choice #5")]
        public int EvolvedChoice4
        {
            get { return this._EvolvedChoice4; }
            set
            {
                if (value != this._EvolvedChoice4)
                {
                    this._EvolvedChoice4 = value;
                    this.NotifyPropertyChanged("EvolvedChoice4");
                }
            }
        }

        [DisplayName("Evolved Choice #6")]
        public int EvolvedChoice5
        {
            get { return this._EvolvedChoice5; }
            set
            {
                if (value != this._EvolvedChoice5)
                {
                    this._EvolvedChoice5 = value;
                    this.NotifyPropertyChanged("EvolvedChoice5");
                }
            }
        }

        [DisplayName("Class Name")]
        public string PowerClassName
        {
            get { return this._PowerClassName; }
            set
            {
                if (value != this._PowerClassName)
                {
                    this._PowerClassName = value;
                    this.NotifyPropertyChanged("PowerClassName");
                }
            }
        }

        [DisplayName("Wheel Display Index")]
        public int WheelDisplayIndex
        {
            get { return this._WheelDisplayIndex; }
            set
            {
                if (value != this._WheelDisplayIndex)
                {
                    this._WheelDisplayIndex = value;
                    this.NotifyPropertyChanged("WheelDisplayIndex");
                }
            }
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
