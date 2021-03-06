﻿/**
 * Copyright © 2010-2017 Atilika Inc. and contributors (see CONTRIBUTORS.md)
 * 
 * Modifications copyright (C) 2017 - 2018 Anki Universal Team <ankiuniversal@gmail.com>
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPJapaneseDictionary.Kuromoji.Core.Dict
{
    public interface IDictionary
    {

        /**
         * Gets the left id of the specified word
         *
         * @param wordId  word id to get left id cost for
         * @return left id cost
         */
        int GetLeftId(int wordId);

        /**
         * Gets the right id of the specified word
         *
         * @param wordId  word id to get right id cost for
         * @return right id cost
         */
        int GetRightId(int wordId);

        /**
         * Gets the word cost of the specified word
         *
         * @param wordId   word id to get word cost for
         * @return word cost
         */
        int GetWordCost(int wordId);

        /**
         * Gets all features of the specified word id
         *
         * @param wordId  word id to get features for
         * @return  All features as a string
         */
        string GetAllFeatures(int wordId);

        /**
         * Gets all features of the specified word id as a String array
         *
         * @param wordId  word id to get features for
         * @return Array with all features
         */
        string[] GetAllFeaturesArray(int wordId);

        /**
         * Gets one or more specific features of a token
         * <p>
         * This is an expert API
         *
         * @param wordId  word id to get features for
         * @param fields array of feature ids. If this array is empty, all features are returned
         * @return Array with specified features
         */
        string GetFeature(int wordId, params int[] fields);
    }
}
