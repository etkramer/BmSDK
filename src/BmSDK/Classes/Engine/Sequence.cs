namespace BmSDK.Engine;

public partial class Sequence
{
    /// <summary>
    /// Retrieves all sequence objects of a given type in the current sequence
    /// and optionally its nested sequences as well.
    /// </summary>
    /// <typeparam name="TClass">SequenceObject type to filter for</typeparam>
    /// <param name="recursive">Whether to search nested sequences too</param>
    /// <returns>Collection of sequence objects of the specified type in the sequence</returns>
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

    /// <summary>
    /// Retrieves all currently active sequence operations of a given type in
    /// the current sequence and optionally its nested sequences as well.
    /// This is useful when searching for currently active SeqActs.
    /// </summary>
    /// <typeparam name="TClass">SequenceOp type to filter for</typeparam>
    /// <param name="recursive">Whether to search nested sequences too</param>
    /// <returns>Collection of sequence ops of the specified type in the sequence</returns>
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
