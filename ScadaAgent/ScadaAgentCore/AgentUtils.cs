﻿/*
 * Copyright 2018 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaServerCommon
 * Summary  : The class contains utility methods for Agent
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2018
 * Modified : 2018
 */

using System.Runtime.InteropServices;

namespace Scada.Agent
{
    /// <summary>
    /// The class contains utility methods for Agent
    /// <para>Класс, содержащий вспомогательные методы для Агента</para>
    /// </summary>
    public static class AgentUtils
    {
        /// <summary>
        /// Версия Агента
        /// </summary>
        public const string AppVersion = "5.0.0.0";

        /// <summary>
        /// Проверить, что программное обеспечение работает под управлением Windows
        /// </summary>
        public static bool IsWindows
        {
            get
            {
                return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
            }
        }
    }
}
