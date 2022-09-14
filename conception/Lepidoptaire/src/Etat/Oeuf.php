<?php

declare(strict_types=1);

namespace Lepidoptaire\Etat;

use Lepidoptaire\IEtat;

final class Oeuf extends Etat  implements IEtat
{
    protected string $name = "Oeuf";

    public function grandir(): IEtat
    {
        return new Larve();
    }
}