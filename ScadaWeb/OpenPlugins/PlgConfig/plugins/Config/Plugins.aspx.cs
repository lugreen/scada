﻿/*
 * Copyright 2016 Mikhail Shiryaev
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
 * Module   : PlgConfig
 * Summary  : Plugins web form
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2016
 * Modified : 2016
 */

using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Scada.Web.Plugins.Config
{
    /// <summary>
    /// Plugins web form
    /// <para>Веб-форма плагинов</para>
    /// </summary>
    public partial class WFrmPlugins : System.Web.UI.Page
    {
        /// <summary>
        /// Элемент списка плагинов
        /// </summary>
        protected class PluginItem
        {
            public bool Active;
            public string Name;
            public string Description;
            public string FileName;
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}