using Impostor.Api.Net.Inner.Objects;

namespace Impostor.Api.Events.Player
{
    public enum VoteType : sbyte
    {
        Skip = -1,
        Player = 0,
        None = 0xf - 1,
    }

    public interface IPlayerVotedEvent : IPlayerEvent
    {
        /// <summary>
        ///     Gets get the player he voted for.
        /// </summary>
        IInnerPlayerControl? VotedFor { get; }

        /// <summary>
        ///     Gets get the Vote type.
        /// </summary>
        VoteType VoteType { get; }
    }
}
