<?php

declare(strict_types=1);

namespace Lepidoptaire\Etat;

use Lepidoptaire\IEtat;

final class Cocon extends Etat implements \Lepidoptaire\IEtat
{
    protected string $name = "Cocon";

    public function grandir(): IEtat
    {
        return new Papillion();
    }
}