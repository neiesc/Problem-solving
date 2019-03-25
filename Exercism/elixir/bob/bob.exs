defmodule Bob do
  def hey(input) do
    cond do
      shouting?(input) && asking_question?(input) && !contatins_number?(input) -> "Calm down, I know what I'm doing!"
      shouting?(input) && !silence?(input) && !contains_only_number?(input) -> "Whoa, chill out!"
      asking_question?(input) -> "Sure."
      silence?(input) -> "Fine. Be that way!"
      true -> "Whatever."
    end
  end

  def shouting?(input) do
    input == String.upcase(input)
  end

  def asking_question?(input) do
    String.last(input) == "?"
  end

  def silence?(input) do
    String.trim(input) == ""
  end

  def contatins_number?(input) do
    Regex.match?(~r/[0-9]/, input)
  end

  def contains_only_number?(input) do
    String.trim(String.replace(input, ~r/([0-9]|,|\?)/, "")) == ""
  end
end
