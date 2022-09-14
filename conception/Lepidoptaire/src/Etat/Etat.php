<?php

namespace Lepidoptaire\Etat;

abstract class Etat
{
    protected string $name;

    public function __toString(): string
    {
        return $this->name;
    }
}