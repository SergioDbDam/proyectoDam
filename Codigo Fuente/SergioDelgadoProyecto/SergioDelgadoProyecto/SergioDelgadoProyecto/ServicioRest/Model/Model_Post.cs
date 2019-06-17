﻿// ***********************************************************************
// Assembly         : SergioDelgadoProyecto
// Author           : Sergio
// Created          : 06-10-2019
//
// Last Modified By : Sergio
// Last Modified On : 06-09-2019
// ***********************************************************************
// <copyright file="Model_Post.cs" company="SergioDelgadoProyecto">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Text;

namespace SergioDelgadoProyecto.ServicioRest
{
    /// <summary>
    /// Modelo de Objetivos
    /// </summary>
    public class Model_Post
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int id { get; set; }
        /// <summary>
        /// Gets or sets the objetivos.
        /// </summary>
        /// <value>The objetivos.</value>
        public string objetivos { get; set; }
        /// <summary>
        /// Gets or sets the fecha.
        /// </summary>
        /// <value>The fecha.</value>
        public DateTime fecha { get; set; }
        /// <summary>
        /// Gets or sets the registro identifier.
        /// </summary>
        /// <value>The registro identifier.</value>
        public int registro_id { get; set; }

    }
}
