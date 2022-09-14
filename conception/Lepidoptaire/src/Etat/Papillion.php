<?php

declare(strict_types=1);

namespace Lepidoptaire\Etat;

use Lepidoptaire\IEtat;

final class Papillion extends Etat  implements \Lepidoptaire\IEtat
{
    protected string $name = "Papillion";

    public function grandir(): IEtat
    {
        return new Mort();
    }
}