/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd
 *
 * Licensed under the Flora License, Version 1.1 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://floralicense.org/license/
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Clock.Interfaces
{
    /// <summary>
    /// The SystemInfo Interface to get system informaion
    /// </summary>
    public interface ISystemInfo
    {
        /// <summary>
        /// Gets system information
        /// </summary>
        /// <param name="key">The name of the key to get</param>
        /// <param name="value">The output value</param>
        /// <returns>Returns the bool value true if it executes successfully; otherwise, returns false. </returns>
        bool TryGetValue<T>(string key, out T value);
    }
}
