//-----------------------------------------------------------------------------
// <copyright file="IEncodable.cs" company="Dropbox Inc">
//  Copyright (c) Dropbox Inc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------------

namespace Dropbox.Api.Babel
{
    /// <summary>
    /// Interface implemented by all objects generated by the babel API generator.
    /// This is used to support transport serialization of objects.
    /// </summary>
    /// <typeparam name="T">The type of the object to encode.</typeparam>
    public interface IEncodable<T>
    {
        /// <summary>
        /// Encodes the object using the supplied encoder.
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        void Encode(IEncoder encoder);

        /// <summary>
        /// Decodes on object using the supplied decoder.
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current instance.</returns>
        T Decode(IDecoder decoder);
    }
}
