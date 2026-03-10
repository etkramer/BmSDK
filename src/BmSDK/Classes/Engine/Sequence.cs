namespace BmSDK.Engine;

public partial class Sequence
{
    public IEnumerable<TClass> FindSeqObjectsByClass<TClass>(bool recursive)
        where TClass : SequenceObject
    {
        var seqObjs = SequenceObjects.OfType<TClass>();

        if (!recursive || NestedSequences.Count == 0)
        {
            return seqObjs;
        }

        return seqObjs.Concat(NestedSequences.SelectMany(s => s.FindSeqObjectsByClass<TClass>(true)));
    }

    public IEnumerable<TClass> FindActiveSeqOpsByClass<TClass>(bool recursive)
        where TClass : SequenceOp
    {
        var seqOps = ActiveSequenceOps.OfType<TClass>();

        if (!recursive || NestedSequences.Count == 0)
        {
            return seqOps;
        }

        return seqOps.Concat(NestedSequences.SelectMany(s => s.FindActiveSeqOpsByClass<TClass>(true)));
    }
}
