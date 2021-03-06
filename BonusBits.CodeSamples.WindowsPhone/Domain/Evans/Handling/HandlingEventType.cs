﻿using System;

namespace BonusBits.CodeSamples.WP7.Domain.Evans.Handling
{
    /// <summary>
    /// Type of handling event.
    /// http://dddsample.sourceforge.net/
    /// </summary>
    public enum HandlingEventType
    {
        Load,
        Unload,
        Receive,
        Claim,
        Customs
    }

    /// <summary>
    /// Contains business logic of <see cref="HandlingEventType"/>.
    /// </summary>
    public static class HandlingEventTypeExtensions
    {
        /// <summary>
        /// Checks if this <see cref="HandlingEventType"/> requires specyfying a <see cref="BonusBits.CodeSamples.WP7.Domain.Evans.Voyage.Voyage"/>
        /// object when constructing new <see cref="HandlingEvent"/>.
        /// </summary>
        /// <param name="eventType">Event type value.</param>
        /// <returns>True, if requires.</returns>
        public static Boolean RequiresVoyage(this HandlingEventType eventType)
        {
            return eventType == HandlingEventType.Load || eventType == HandlingEventType.Unload;
        }
        /// <summary>
        /// Checks if this <see cref="HandlingEventType"/> prohibits specyfying a <see cref="BonusBits.CodeSamples.WP7.Domain.Evans.Voyage.Voyage"/>
        /// object when constructing new <see cref="HandlingEvent"/>.
        /// </summary>
        /// <param name="eventType">Event type value.</param>
        /// <returns>True, if prohibits.</returns>
        public static Boolean ProhibitsVoyage(this HandlingEventType eventType)
        {
            return !RequiresVoyage(eventType);
        }
    }
}
