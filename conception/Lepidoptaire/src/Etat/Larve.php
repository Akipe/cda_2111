<?php

declare(strict_types=1);

namespace Lepidoptaire\Etat;

use Lepidoptaire\IEtat;

final class Larve extends Etat implements \Lepidoptaire\IEtat
{
    protected string $name = "Larve";

    public function grandir(): IEtat
    {
        return new Cocon();
    }
}