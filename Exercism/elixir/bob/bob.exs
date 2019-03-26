defmodule Bob do
  def hey(input) do
    shouting? = input == String.upcase(input)
    asking_question? = String.last(input) == "?"
    silence? = String.trim(input) == ""
    contatins_number? = Regex.match?(~r/[0-9]/, input)
    contains_only_number? = String.trim(String.replace(input, ~r/([0-9]|,|\?)/, "")) == ""

    cond do
      shouting? && asking_question? && !contatins_number? -> "Calm down, I know what I'm doing!"
      shouting? && !silence? && !contains_only_number? -> "Whoa, chill out!"
      asking_question? -> "Sure."
      silence? -> "Fine. Be that way!"
      true -> "Whatever."
    end
  end
end
