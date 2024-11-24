#region Using Statements
using System;
using System.Collections.Generic;
using System.Diagnostics;

using FNA.Audio;
using FNA.Input;
using FNA.Content;
using FNA.Graphics;
using FNA.Input.Touch;
#endregion

namespace FNA
{
	public static class GameAudio
	{
		public static bool IsDisposed { get; private set; }

		private static readonly ContentManager Content = new ContentManager(null);

		public static string RootDirectory
		{
			set => Content.RootDirectory = value;
			get => Content.RootDirectory;
		}

		public static FNA.Audio.SoundEffect LoadSoundEffect(string audioFilePath)
			=> Content.Load<FNA.Audio.SoundEffect>(audioFilePath);

		public static void Update()
			=> FrameworkDispatcher.Update();

		public static void Dispose()
		{
			if (!IsDisposed)
			{
				if (Content != null)
				{
					Content.Dispose();
				}
				IsDisposed = true;
			}
		}
	}
}
