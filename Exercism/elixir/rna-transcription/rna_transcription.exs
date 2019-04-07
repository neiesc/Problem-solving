defmodule RNATranscription do
  @doc """
  Transcribes a character list representing DNA nucleotides to RNA

  ## Examples

  iex> RNATranscription.to_rna('ACTG')
  'UGAC'
  """
  @spec to_rna([char]) :: [char]
  def to_rna(dna) do
    Enum.map(String.graphemes(to_string(dna)), fn x -> get_transcription(x) end)
      |> Enum.join("")
      |> String.to_charlist
  end

  def get_transcription(dna) do
    cond do
      dna === "G" -> 'C'
      dna === "C" -> 'G'
      dna === "T" -> 'A'
      dna === "A" -> 'U'
      true -> dna
    end
  end
end
