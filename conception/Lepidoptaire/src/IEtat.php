<?php

declare(strict_types=1);

namespace Lepidoptaire;

interface IEtat
{
    public function grandir(): IEtat;
    public function __toString(): string;
}