using static ExoScan.CodexData.CodexIds;

namespace ExoScan.RuleSets
{

    // Assuming you have these catalog classes from previous conversions
    // using BioScan.BioData.Rulesets;

    public class BioRules
    {
        public static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> Rules = MergeCatalogs(
            Species.Amphora,
            Species.Aleoida,
            Species.Anemone,
            Species.Bacterial,
            Species.Brancae,
            Species.Cactoid,
            Species.Clypeus,
            Species.Conchas,
            Species.Electricae,
            Species.Fonticulus,
            Species.Shrubs,
            Species.Fumerolas,
            Species.Fungoids,
            Species.Osseus,
            Species.Recepta,
            Species.GroundStructIce,
            Species.Stratum,
            Species.Tube,
            Species.Tubus,
            Species.Tussocks
        );

        private static Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>> MergeCatalogs(
            params Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>[] catalogs)
        {
            var result = new Dictionary<GenusEnum, Dictionary<ushort, SpeciesRules>>();

            foreach (var catalog in catalogs)
            {
                foreach (var kvp in catalog)
                {
                    result[kvp.Key] = kvp.Value;
                }
            }

            return result;
        }
    }


}
