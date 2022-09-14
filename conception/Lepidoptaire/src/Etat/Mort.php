<?php

declare(strict_types=1);

namespace Lepidoptaire\Etat;

use Lepidoptaire\IEtat;

final class Mort extends Etat  implements IEtat
{
    protected string $name = "Mort";

    public function grandir(): IEtat
    {
        return $this;
    }
}