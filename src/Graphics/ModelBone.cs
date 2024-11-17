#region License
/* FNA - XNA4 Reimplementation for Desktop Platforms
 * Copyright 2009-2024 Ethan Lee and the MonoGame Team
 *
 * Released under the Microsoft Public License.
 * See LICENSE for details.
 */
#endregion

#region Using Statements
using System.Collections.Generic;
#endregion

namespace Microsoft.Xna.Framework.Graphics
{
	/// <summary>
	/// Represents bone data for a model.
	/// </summary>
	public sealed class ModelBone
	{
		#region Public Properties

		/// <summary>
		/// Gets a collection of bones that are children of this bone.
		/// </summary>
		public ModelBoneCollection Children
		{
			get;
			private set;
		}

		/// <summary>
		/// Gets the index of this bone in the Bones collection.
		/// </summary>
		// (WCS Edit) This internal set accessor is converted to public.
		public int Index
		{
			get;
			set;
		}

		/// <summary>
		/// Gets the name of this bone.
		/// </summary>
		// (WCS Edit) This internal set accessor is converted to public.
		public string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Gets the parent of this bone.
		/// </summary>
		// (WCS Edit) This internal set accessor is converted to public.
		public ModelBone Parent
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the matrix used to transform this bone relative to its parent
		/// bone.
		/// </summary>
		public Matrix Transform
		{
			get;
			set;
		}

		#endregion

		#region Private Variables

		private List<ModelBone> children = new List<ModelBone>();
		private List<ModelMesh> meshes = new List<ModelMesh>();

		#endregion

		#region Internal Constructor

		// (WCS Edit) This internal constructor is converted internal accessor to public.
		public ModelBone()
		{
			Children = new ModelBoneCollection(new List<ModelBone>());
			meshes = new List<ModelMesh>();
		}

		#endregion

		#region Internal Methods

		// (WCS Edit) These internal methods are converted internal accessor to public.
		public void AddMesh(ModelMesh mesh)
		{
			meshes.Add(mesh);
		}

		public void AddChild(ModelBone modelBone)
		{
			children.Add(modelBone);
			Children = new ModelBoneCollection(children);
		}

		#endregion
	}
}
