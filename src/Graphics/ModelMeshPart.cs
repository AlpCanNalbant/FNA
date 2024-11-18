#region License
/* FNA - XNA4 Reimplementation for Desktop Platforms
 * Copyright 2009-2024 Ethan Lee and the MonoGame Team
 *
 * Released under the Microsoft Public License.
 * See LICENSE for details.
 */
#endregion

namespace FNA.Graphics
{
	public sealed class ModelMeshPart
	{
		#region Public Properties

		/// <summary>
		/// Gets or sets the material Effect for this mesh part.
		/// </summary>
		public Effect Effect
		{
			get
			{
				return INTERNAL_effect;
			}
			set
			{
				if (value == INTERNAL_effect)
				{
					return;
				}

				if (INTERNAL_effect != null)
				{
					// First check to see any other parts are also using this effect.
					bool removeEffect = true;
					foreach (ModelMeshPart part in parent.MeshParts)
					{
						if (part != this && part.INTERNAL_effect == INTERNAL_effect)
						{
							removeEffect = false;
							break;
						}
					}

					if (removeEffect)
					{
						parent.Effects.Remove(INTERNAL_effect);
					}
				}

				// Set the new effect.
				INTERNAL_effect = value;

				if (INTERNAL_effect != null && !parent.Effects.Contains(INTERNAL_effect))
				{
					parent.Effects.Add(value);
				}
			}
		}

		/// <summary>
		/// Gets the index buffer for this mesh part.
		/// </summary>
		// (WCS Edit) This internal set accessor is converted to public.
		public IndexBuffer IndexBuffer
		{
			get;
			set;
		}

		/// <summary>
		/// Gets the number of vertices used during a draw call.
		/// </summary>
		// (WCS Edit) This internal set accessor is converted to public.
		public int NumVertices
		{
			get;
			set;
		}

		/// <summary>
		/// Gets the number of primitives to render.
		/// </summary>
		// (WCS Edit) This internal set accessor is converted to public.
		public int PrimitiveCount
		{
			get;
			set;
		}

		/// <summary>
		/// Gets the location in the index array at which to start reading vertices.
		/// </summary>
		// (WCS Edit) This internal set accessor is converted to public.
		public int StartIndex
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets an object identifying this model mesh part.
		/// </summary>
		public object Tag
		{
			get;
			set;
		}

		/// <summary>
		/// Gets the vertex buffer for this mesh part.
		/// </summary>
		// (WCS Edit) This internal set accessor is converted to public.
		public VertexBuffer VertexBuffer
		{
			get;
			set;
		}

		/// <summary>
		/// Gets the offset (in vertices) from the top of vertex buffer.
		/// </summary>
		// (WCS Edit) This internal set accessor is converted to public.
		public int VertexOffset
		{
			get;
			set;
		}

		#endregion

		#region Internal Variables

		internal ModelMesh parent;

		#endregion

		#region Private Variables

		private Effect INTERNAL_effect;

		#endregion

		#region Internal Constructor

		// (WCS Edit) This internal constructor is converted internal accessor to public.
		public ModelMeshPart()
		{
		}

		#endregion
	}
}
