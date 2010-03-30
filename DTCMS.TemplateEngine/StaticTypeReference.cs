using System;

namespace Ader.TemplateEngine
{
	/// <summary>
	/// StaticTypeReference is used by TemplateManager to hold references to types.
	/// When invoking methods, or accessing properties of this object, it will actually
	/// do static methods of the type
	/// </summary>
	class StaticTypeReference
	{
        private readonly Type type;

		public StaticTypeReference(Type type)
		{
			this.type = type;
		}

		public Type Type
		{
			get { return type; }
		}
	}
}
