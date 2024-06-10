<!-- ⚠️ This README has been generated from the file(s) "blueprint.md" ⚠️--><p align="center">
    
  <img src="https://raw.githubusercontent.com/andreasbm/readme/master/assets/logo-shadow.png" alt="Logo" width="150" height="150" />
  
  


<p align="center">
  <b>Automatically generate a beautiful best-practice README file based on the contents of your repository</b></br>
  <sub>Use this readme generator to easily generate beautiful readme's like this one! Simply extend your <code>package.json</code> and create a readme blueprint. On Github, the README file is like the landing page of your website because it is the first thing visitors see. You want to make a good first impression.<sub>

[![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/colored.png)](#installation)

## ➤ Installation

```javascript
npm install @appnest/readme -D
```

If you don't want to install anything you can use the `npx @appnest/readme generate` command instead.

[![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/colored.png)](#getting-started-quick)

## ➤ Getting Started (quick)

This getting started guide is super quick! Follow these two steps and you will have turned your boring readme into a pretty one.

1. Rename your current `README.md` file to `blueprint.md`.
2. Run `npx @appnest/readme generate`

That's it! Check out your freshly generated `README.md` file and enjoy the fruits of what you just did.


[![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/colored.png)](#getting-started-slower)

## ➤ Getting Started (slower)

```

### Usage

Run the `node_modules/.bin/readme generate` command and a README file will be generated for you. If you want to go into depth with the readme command, check out the following options or write `node_modules/.bin/readme generate -h` in your terminal if that's your cup of tea.


| Option                | Type                                             | Description                                      |
|-----------------------|--------------------------------------------------|--------------------------------------------------|
| -c, --config          | string                                           | Path of the configuration file. Defaults to 'blueprint.json |
| -p, --package         | string                                           | Path of the 'package.json' file. Defaults to 'package.json'. |
| --pkg.name            | string                                           | Name of the project. Used for the 'title' template. |
| --pkg.contributors    | {name: string; email: string; url: string; img: string; info: string[];}[] | Contributors of the project. Used for the 'contributors' template. |
| --pkg.license         | string                                           | License kind. Used for the 'license' template.   |
| -o, --output          | string                                           | Path of the generated README file. Defaults to 'README.md'. |
| -h, --help            |                                                  | Display this help message.                       |
| -i, --input           | string                                           | The blueprint. Defaults to 'blueprint.md'.       |
| --badges              | {alt: string, url: string, img: string}[]        | Badges. Used for the 'badges' template.          |
| --text                | string                                           | Text describing your project. Used for the 'description' template. |
| --demo                | string                                           | Demo url for your project. Used for the 'description' template. |
| --lineBreak           | string                                           | The linebreak used in the generation of the README file. Defaults to 'rn' |
| --tab                 | string                                           | The tab used in the generation of the README file. Defaults to 't' |
| --placeholder         | [string, string]                                 | The placeholder syntax used when looking for templates in the blueprint. Defaults to '["{{", "}}"]. |
| --line                | string                                           | The line style of the titles. Can also be an URL. Defaults to 'colored'. |
| --templates           | {name: string, template: string}[]               | User created templates.                          |
| -s, --silent          | boolean                                          | Whether the console output from the command should be silent. |
| -d, --dry             | boolean                                          | Whether the command should run as dry. If dry, the output file is notgenerated but outputted to the console instead. |
| --headingPrefix       | {[key: number]: string}                          | The prefix of the header tags. Defaults to '{1: "➤ ", 2: "➤ "}' |
| --logo                | {src: string; alt?: string; width?: number; height?: number;} | The logo information. Used for the 'logo' template. |
| --contributorsPerRow  | number                                           | The amount of contributors pr row when using the 'contributors' template. Defaults to '6' |
| --documentationConfig | object                                           | Configuration object for automatic documentation template. |
| --extend              | string                                           | Path to another configuration object that should be extended. |
| --checkLinks          | boolean                                          | Checks all links for aliveness after the README file has been generated. |


### Configuration

To configure this library you'll need to create a `blueprint.json` file. This file is the configuration for the templates we are going to take a look at in the next section. If you want to interpolate values from the configuration file into your README file you can simply reference them without a scope. Eg. if you have the field "link" in your `blueprint.json` you can write `{{ link }}` to reference it.

Great. Now that we have the basics covered, let's continue and see how you can use templates!

[![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/colored.png)](#templates)

## ➤ Templates

If you have come this far you are probably interested to figure out how to use README templates. This library comes with a set of pre-defined templates to make your readme awesome, but you can of course create your own. More about that later, let's not get ahead of our self just yet.

### Title

Let's start with the title template. To generate the title you write `{{ template:title }}` in your blueprint. When you run the `readme` command the template will generate the following:

<h1 align="center">@appnest/readme</h1>

The important thing to note here is that the template automatically reads your `package.json` file and inserts the `name` from the package.

```json
{
  "name": "@appnest/readme"
}
```

That's cool. Let's go through some of the other built-in templates you might want to add.

### Logo

The logo template adds a logo to your readme and looks like this:

<p align="center">
  <img src="https://raw.githubusercontent.com/andreasbm/readme/master/assets/logo-shadow.png" alt="Logo" width="150" height="150" />
</p>


Then you can stamp your custom template using the `{{ template:install }}` syntax ("install" here referencing the name of the custom template). The below is an example of what is stamped to the README file using the above template.

Run `npm install @appnest/readme' to install this library!

Be creative! You can for example add a template for code-snippets or [words you keep spelling wrong](https://en.oxforddictionaries.com/spelling/common-misspellings).

[![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/colored.png)](#advanced)




| Attribute  | Type              | Description                          |
|------------|-------------------|--------------------------------------|
| **size**   | 'medium', 'large' | Determines the size                  |
| **active** | boolean           | Whether the element is active or not |
|Ingles | bolean                | wdwd

![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/dark.png)


[![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/colored.png)](#contributors)

## ➤ Contributors
	

| [<img alt="Andreas Mehlsen" src="https://avatars1.githubusercontent.com/u/6267397?s=460&v=4" width="100">](https://twitter.com/andreasmehlsen) | [<img alt="You?" src="https://joeschmoe.io/api/v1/random" width="100">](https://github.com/andreasbm/readme/blob/master/CONTRIBUTING.md) |
|:--------------------------------------------------:|:--------------------------------------------------:|
| [Andreas Mehlsen](https://twitter.com/andreasmehlsen) | [You?](https://github.com/andreasbm/readme/blob/master/CONTRIBUTING.md) |
| 🔥                                               |                                                  |


[![-----------------------------------------------------](https://raw.githubusercontent.com/andreasbm/readme/master/assets/lines/colored.png)](#license)

## ➤ License
	
Licensed under [MIT](https://opensource.org/licenses/MIT).