# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

import types

__config__ = pulumi.Config('hetznerdns')


class _ExportableConfig(types.ModuleType):
    @property
    def apitoken(self) -> Optional[str]:
        """
        The API access token to authenticate at Hetzner DNS API.
        """
        return __config__.get('apitoken')

