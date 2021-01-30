
using System;
using System.Runtime.Serialization;

namespace Examen
{
	/// <summary>
	/// Description of SobrepasaStockException.
	/// </summary>
	public class SobrepasaStockException : Exception, ISerializable
	{
		public SobrepasaStockException()
		{
		}

	 	public SobrepasaStockException(string message) : base(message)
		{
		}

		public SobrepasaStockException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// This constructor is needed for serialization.
		protected SobrepasaStockException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}