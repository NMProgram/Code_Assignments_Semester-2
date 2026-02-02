class DNA
{
    public string Seq;
    public DNA(string seq) => Seq = seq;
    public DNA Replicate1() => new(Seq);
    public DNA Replicate2() => this;
    public void Mutate(string otherSeq) => Seq = otherSeq;
}
