<?php

declare(strict_types=1);

use Lepidoptaire\Lepidoptaire;

require __DIR__ . '/vendor/autoload.php';

$lepidoptaire = new Lepidoptaire();

echo $lepidoptaire->getEtat();
echo "\n\n";

$lepidoptaire->grandrir();
echo $lepidoptaire->getEtat();
echo "\n\n";

$lepidoptaire->grandrir();
echo $lepidoptaire->getEtat();
echo "\n\n";

$lepidoptaire->grandrir();
echo $lepidoptaire->getEtat();
echo "\n\n";

$lepidoptaire->grandrir();
echo $lepidoptaire->getEtat();
echo "\n\n";

$lepidoptaire->grandrir();
echo $lepidoptaire->getEtat();
echo "\n\n";
