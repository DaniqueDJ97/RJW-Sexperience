﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rjw;
using RimWorld;
using Verse;



namespace RJWSexperience
{
    public class CumOutcomeDoers : IngestionOutcomeDoer
    {
        public float unitAmount = 1.0f;

        protected override void DoIngestionOutcomeSpecial(Pawn pawn, Thing ingested)
        {
            pawn.records.Increment(VariousDefOf.NumCumFood);
            pawn.records.AddTo(VariousDefOf.AmountofEatenCum, ingested.stackCount * unitAmount);
            pawn.CumDrugEffect();
        }
    }
}
