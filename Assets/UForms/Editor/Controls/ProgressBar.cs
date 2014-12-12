﻿using UnityEngine;
using UnityEditor;
using System.Collections;

namespace UForms.Controls
{
    /// <summary>
    /// 
    /// </summary>
    public class ProgressBar : Control
    {
        /// <summary>
        /// 
        /// </summary>
        public string           Text           { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public float            Progress       { get; set; }

        /// <summary>
        /// 
        /// </summary>
        protected override Vector2 DefaultSize {
            get { return new Vector2( 200.0f, 16.0f ); }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="progress"></param>
        public ProgressBar( string text = "", float progress = 0.0f ) : base()
        {
            Text     = text;
            Progress = progress;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <param name="size"></param>
        /// <param name="text"></param>
        /// <param name="progress"></param>
        public ProgressBar( Vector2 position, Vector2 size, string text = "", float progress = 0.0f ) : base( position, size )
        {            
            Text     = text;
            Progress = progress;
        }


        /// <summary>
        /// 
        /// </summary>
        protected override void OnDraw()
        {
            Progress = Mathf.Clamp01( Progress );
            EditorGUI.ProgressBar( ScreenRect, Progress, Text );
        }
    }
}