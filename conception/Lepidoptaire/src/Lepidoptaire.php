<?php

declare(strict_types=1);

namespace Lepidoptaire;

use Lepidoptaire\Etat\Oeuf;

final class Lepidoptaire
{
    private IEtat $etat;

    public function __construct()
    {
        $this->etat = new Oeuf();
    }

    public function grandrir(): void
    {
        $this->etat = $this->etat->grandir();
    }

    public function getEtat(): string
    {
        return $this->etat->__toString();
    }
}