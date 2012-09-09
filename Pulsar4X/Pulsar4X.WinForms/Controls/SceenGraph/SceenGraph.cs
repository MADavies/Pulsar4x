﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pulsar4X;
using Pulsar4X.WinForms;
using Pulsar4X.WinForms.GLUtilities;
using OpenTK;

namespace Pulsar4X.WinForms.Controls.SceenGraph
{
    /// <summary>
    /// Root Node of a Sceen Graph
    /// </summary>
    public class SceenGraph
    {
        /// <summary>
        /// List of all top level Sprites That Make up the Sceen.
        /// </summary>
        private List<SceenElement> m_lElements = new List<SceenElement>();

        /// <summary>
        /// Gets a list of the Elements that make up the sceen.
        /// </summary>
        public List<SceenElement> Elements
        {
            get
            {
                return m_lElements;
            }
        }

        /// <summary> 
        /// The zoom scaler, make this smaller to zoom out, larger to zoom in.
        /// </summary>
        private float m_fZoomScaler = UIConstants.ZOOM_DEFAULT_SCALLER;

        /// <summary>
        /// Gets or Sets the ZoomScaler for the Sceen.
        /// </summary>
        public float ZoomSclaer
        {
            get
            {
                return m_fZoomScaler;
            }
            set
            {
                m_fZoomScaler = value;
            }
        }

        /// <summary> 
        /// The view offset, i.e. how much the view should be offset from 0, 0 
        /// </summary>
        private Vector3 m_v3ViewOffset = new Vector3(0, 0, 0);

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SceenGraph()
        {
        }

        /// <summary>
        /// Render the Sceen.
        /// </summary>
        public void Render()
        {
            foreach (SceenElement oElement in m_lElements)
            {
                oElement.Render();
            }
        }

        /// <summary>
        /// Refresh the Sceen
        /// </summary>
        public void Refresh()
        {
            foreach (SceenElement oElement in m_lElements)
            {
                oElement.Refresh(m_fZoomScaler);
            }
        }
    }
}