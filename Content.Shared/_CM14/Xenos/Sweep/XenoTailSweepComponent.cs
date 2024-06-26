﻿using Content.Shared.Damage;
using Content.Shared.FixedPoint;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._CM14.Xenos.Sweep;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(XenoTailSweepSystem))]
public sealed partial class XenoTailSweepComponent : Component
{
    [DataField, AutoNetworkedField]
    public FixedPoint2 PlasmaCost = 10;

    [DataField, AutoNetworkedField]
    public float Range = 1;

    [DataField]
    public DamageSpecifier? Damage;

    // TODO CM14 scale with damage dealt up to a cap
    [DataField, AutoNetworkedField]
    public TimeSpan StunTime = TimeSpan.FromSeconds(2);

    [DataField, AutoNetworkedField]
    public SoundSpecifier Sound = new SoundCollectionSpecifier("XenoTailSwipe");

    [DataField, AutoNetworkedField]
    public EntProtoId HitEffect = "CMEffectPunch";

    [DataField, AutoNetworkedField]
    public SoundSpecifier HitSound = new SoundPathSpecifier("/Audio/_CM14/Xeno/alien_claw_block.ogg");
}
