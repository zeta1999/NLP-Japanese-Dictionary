﻿/**
 * Copyright © 2017-2018 Anki Universal Team.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may
 * not use this file except in compliance with the License.  A copy of the
 * License is distributed with this work in the LICENSE.md file.  You may
 * also obtain a copy of the License from
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using NLPJapaneseDictionary.Kuromoji.Interfaces;
using NLPJapaneseDictionary.KuromojiIpadic.Ipadic;
using NLPJapaneseDictionary.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NLPJapaneseDictionary.Models
{
    public class TokenModel : INotifyPropertyChanged
    {
        private string surface;
        public string Surface
        {
            get
            {
                return surface;
            }
            set
            {
                surface = value;
                RaisePropertyChanged("Surface");
            }
        }

        private string conjugationType;
        public string ConjugationType
        {
            get
            {
                return conjugationType;
            }
            set
            {
                conjugationType = value;
                RaisePropertyChanged("ConjugationType");
            }
        }

        private string conjugationForm;
        public string ConjugationForm
        {
            get
            {
                return conjugationForm;
            }
            set
            {
                conjugationForm = value;
                RaisePropertyChanged("ConjugationForm");
            }
        }

        private string baseForm;
        public string BaseForm
        {
            get
            {
                return baseForm;
            }
            set
            {
                baseForm = value;
                RaisePropertyChanged("BaseForm");
            }
        }

        private string reading;
        public string Reading
        {
            get
            {
                return reading;
            }
            set
            {
                reading = value;
                RaisePropertyChanged("Reading");
            }
        }

        private string pronunciation;
        public string Pronunciation
        {
            get
            {
                return pronunciation;
            }
            set
            {
                pronunciation = value;
                RaisePropertyChanged("Pronunciation");
            }
        }

        private string partOfSpeech;
        public string PartOfSpeech
        {
            get
            {
                return partOfSpeech;
            }
            set
            {
                partOfSpeech = value;
                RaisePropertyChanged("PartOfSpeech1");
            }
        }

        public TokenModel(IToken token)
        {
            surface = token.Surface;
            conjugationType = token.ConjugationType;
            conjugationForm = token.ConjugationForm;
            baseForm = token.BaseForm;
            reading = token.Reading;
            pronunciation = token.Pronunciation;
            partOfSpeech = token.PartOfSpeech;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
