// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Users
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Space is allocated differently based on the type of account.</para>
    /// </summary>
    public class SpaceAllocation : enc.IEncodable<SpaceAllocation>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SpaceAllocation" />
        /// class.</para>
        /// </summary>
        public SpaceAllocation()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Individual</para>
        /// </summary>
        public bool IsIndividual
        {
            get
            {
                return this is Individual;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Individual, or <c>null</c>.</para>
        /// </summary>
        public Individual AsIndividual
        {
            get
            {
                return this as Individual;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Team</para>
        /// </summary>
        public bool IsTeam
        {
            get
            {
                return this is Team;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Team, or <c>null</c>.</para>
        /// </summary>
        public Team AsTeam
        {
            get
            {
                return this as Team;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region IEncodable<SpaceAllocation> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<SpaceAllocation>.Encode(enc.IEncoder encoder)
        {
            if (this.IsIndividual)
            {
                ((enc.IEncodable<Individual>)this).Encode(encoder);
            }
            else if (this.IsTeam)
            {
                ((enc.IEncodable<Team>)this).Encode(encoder);
            }
            else
            {
                ((enc.IEncodable<Other>)this).Encode(encoder);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        SpaceAllocation enc.IEncodable<SpaceAllocation>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "individual":
                var individual = new IndividualSpaceAllocation();
                return new Individual(((enc.IEncodable<IndividualSpaceAllocation>)individual).Decode(decoder));
            case "team":
                var team = new TeamSpaceAllocation();
                return new Team(((enc.IEncodable<TeamSpaceAllocation>)team).Decode(decoder));
            default:
                return Other.Instance;
            }
        }

        #endregion

        /// <summary>
        /// <para>The user's space allocation applies only to their individual account.</para>
        /// </summary>
        public sealed class Individual : SpaceAllocation, enc.IEncodable<Individual>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Individual" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Individual(IndividualSpaceAllocation value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public IndividualSpaceAllocation Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<Individual>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "individual");
                    obj.AddField("individual", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Individual enc.IEncodable<Individual>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The user shares space with other members of their team.</para>
        /// </summary>
        public sealed class Team : SpaceAllocation, enc.IEncodable<Team>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Team" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Team(TeamSpaceAllocation value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public TeamSpaceAllocation Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<Team>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "team");
                    obj.AddField("team", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Team enc.IEncodable<Team>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : SpaceAllocation, enc.IEncodable<Other>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<Other>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "other");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Other enc.IEncodable<Other>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }
    }
}
